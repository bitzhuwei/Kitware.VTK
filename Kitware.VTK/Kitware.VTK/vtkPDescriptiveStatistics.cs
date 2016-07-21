using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPDescriptiveStatistics : vtkDescriptiveStatistics
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDescriptiveStatistics";

		public new static readonly string MRClassNameKey;

		static vtkPDescriptiveStatistics()
		{
			vtkPDescriptiveStatistics.MRClassNameKey = "class vtkPDescriptiveStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDescriptiveStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDescriptiveStatistics"));
		}

		public vtkPDescriptiveStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPDescriptiveStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDescriptiveStatistics New()
		{
			vtkPDescriptiveStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPDescriptiveStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPDescriptiveStatistics_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPDescriptiveStatistics_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPDescriptiveStatistics_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPDescriptiveStatistics_Learn_04(HandleRef pThis, HandleRef inData, HandleRef inParameters, HandleRef outMeta);

		public virtual void Learn(vtkTable inData, vtkTable inParameters, vtkMultiBlockDataSet outMeta)
		{
			vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_Learn_04(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (inParameters == null) ? default(HandleRef) : inParameters.GetCppThis(), (outMeta == null) ? default(HandleRef) : outMeta.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPDescriptiveStatistics_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPDescriptiveStatistics NewInstance()
		{
			vtkPDescriptiveStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPDescriptiveStatistics_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPDescriptiveStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPDescriptiveStatistics vtkPDescriptiveStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDescriptiveStatistics = (vtkPDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDescriptiveStatistics.Register(null);
				}
			}
			return vtkPDescriptiveStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPDescriptiveStatistics_SetController_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPDescriptiveStatistics.vtkPDescriptiveStatistics_SetController_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
