using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCorrelativeStatistics : vtkCorrelativeStatistics
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCorrelativeStatistics";

		public new static readonly string MRClassNameKey;

		static vtkPCorrelativeStatistics()
		{
			vtkPCorrelativeStatistics.MRClassNameKey = "class vtkPCorrelativeStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCorrelativeStatistics"));
		}

		public vtkPCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCorrelativeStatistics New()
		{
			vtkPCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCorrelativeStatistics_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCorrelativeStatistics_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCorrelativeStatistics_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCorrelativeStatistics_Learn_04(HandleRef pThis, HandleRef inData, HandleRef inParameters, HandleRef outMeta);

		public virtual void Learn(vtkTable inData, vtkTable inParameters, vtkMultiBlockDataSet outMeta)
		{
			vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_Learn_04(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (inParameters == null) ? default(HandleRef) : inParameters.GetCppThis(), (outMeta == null) ? default(HandleRef) : outMeta.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCorrelativeStatistics_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCorrelativeStatistics NewInstance()
		{
			vtkPCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCorrelativeStatistics_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPCorrelativeStatistics vtkPCorrelativeStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCorrelativeStatistics = (vtkPCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCorrelativeStatistics.Register(null);
				}
			}
			return vtkPCorrelativeStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCorrelativeStatistics_SetController_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPCorrelativeStatistics.vtkPCorrelativeStatistics_SetController_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
