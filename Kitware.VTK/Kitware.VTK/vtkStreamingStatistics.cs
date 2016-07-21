using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamingStatistics : vtkTableAlgorithm
	{
		public enum InputPorts
		{
			INPUT_DATA,
			INPUT_MODEL = 2,
			LEARN_PARAMETERS = 1
		}

		public enum OutputIndices
		{
			ASSESSMENT = 2,
			OUTPUT_DATA = 0,
			OUTPUT_MODEL,
			OUTPUT_TEST
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingStatistics";

		public new static readonly string MRClassNameKey;

		static vtkStreamingStatistics()
		{
			vtkStreamingStatistics.MRClassNameKey = "class vtkStreamingStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamingStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingStatistics"));
		}

		public vtkStreamingStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingStatistics New()
		{
			vtkStreamingStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamingStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamingStatistics.vtkStreamingStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStreamingStatistics_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStreamingStatistics_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamingStatistics.vtkStreamingStatistics_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingStatistics_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamingStatistics NewInstance()
		{
			vtkStreamingStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingStatistics_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkStreamingStatistics vtkStreamingStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingStatistics.vtkStreamingStatistics_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingStatistics = (vtkStreamingStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingStatistics.Register(null);
				}
			}
			return vtkStreamingStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStreamingStatistics_SetStatisticsAlgorithm_06(HandleRef pThis, HandleRef arg0);

		public virtual void SetStatisticsAlgorithm(vtkStatisticsAlgorithm arg0)
		{
			vtkStreamingStatistics.vtkStreamingStatistics_SetStatisticsAlgorithm_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
