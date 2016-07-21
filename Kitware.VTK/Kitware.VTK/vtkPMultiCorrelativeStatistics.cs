using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPMultiCorrelativeStatistics : vtkMultiCorrelativeStatistics
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPMultiCorrelativeStatistics";

		public new static readonly string MRClassNameKey;

		static vtkPMultiCorrelativeStatistics()
		{
			vtkPMultiCorrelativeStatistics.MRClassNameKey = "class vtkPMultiCorrelativeStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPMultiCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPMultiCorrelativeStatistics"));
		}

		public vtkPMultiCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPMultiCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPMultiCorrelativeStatistics New()
		{
			vtkPMultiCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPMultiCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPMultiCorrelativeStatistics_GatherStatistics_01(HandleRef curController, HandleRef sparseCov);

		public static void GatherStatistics(vtkMultiProcessController curController, vtkTable sparseCov)
		{
			vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_GatherStatistics_01((curController == null) ? default(HandleRef) : curController.GetCppThis(), (sparseCov == null) ? default(HandleRef) : sparseCov.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPMultiCorrelativeStatistics_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPMultiCorrelativeStatistics_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPMultiCorrelativeStatistics_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPMultiCorrelativeStatistics_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPMultiCorrelativeStatistics NewInstance()
		{
			vtkPMultiCorrelativeStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPMultiCorrelativeStatistics_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPMultiCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPMultiCorrelativeStatistics vtkPMultiCorrelativeStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPMultiCorrelativeStatistics = (vtkPMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPMultiCorrelativeStatistics.Register(null);
				}
			}
			return vtkPMultiCorrelativeStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPMultiCorrelativeStatistics_SetController_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPMultiCorrelativeStatistics.vtkPMultiCorrelativeStatistics_SetController_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
