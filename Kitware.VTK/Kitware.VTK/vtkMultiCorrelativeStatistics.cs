using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiCorrelativeStatistics : vtkStatisticsAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiCorrelativeStatistics";

		public new static readonly string MRClassNameKey;

		static vtkMultiCorrelativeStatistics()
		{
			vtkMultiCorrelativeStatistics.MRClassNameKey = "class vtkMultiCorrelativeStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiCorrelativeStatistics"));
		}

		public vtkMultiCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiCorrelativeStatistics New()
		{
			vtkMultiCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMultiCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMultiCorrelativeStatistics_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMultiCorrelativeStatistics_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiCorrelativeStatistics NewInstance()
		{
			vtkMultiCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiCorrelativeStatistics_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkMultiCorrelativeStatistics vtkMultiCorrelativeStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiCorrelativeStatistics.vtkMultiCorrelativeStatistics_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiCorrelativeStatistics = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiCorrelativeStatistics.Register(null);
				}
			}
			return vtkMultiCorrelativeStatistics;
		}
	}
}
