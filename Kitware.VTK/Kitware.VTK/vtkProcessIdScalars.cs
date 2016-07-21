using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProcessIdScalars : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcessIdScalars";

		public new static readonly string MRClassNameKey;

		static vtkProcessIdScalars()
		{
			vtkProcessIdScalars.MRClassNameKey = "class vtkProcessIdScalars";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcessIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessIdScalars"));
		}

		public vtkProcessIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcessIdScalars New()
		{
			vtkProcessIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProcessIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProcessIdScalars.vtkProcessIdScalars_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessIdScalars_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessIdScalars_GetRandomMode_02(HandleRef pThis);

		public virtual int GetRandomMode()
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetRandomMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessIdScalars_GetScalarMode_03(HandleRef pThis);

		public int GetScalarMode()
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetScalarMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessIdScalars_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcessIdScalars_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessIdScalars_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProcessIdScalars NewInstance()
		{
			vtkProcessIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_RandomModeOff_08(HandleRef pThis);

		public virtual void RandomModeOff()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_RandomModeOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_RandomModeOn_09(HandleRef pThis);

		public virtual void RandomModeOn()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_RandomModeOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessIdScalars_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcessIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkProcessIdScalars vtkProcessIdScalars = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessIdScalars = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessIdScalars.Register(null);
				}
			}
			return vtkProcessIdScalars;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_SetController_11(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetController_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_SetRandomMode_12(HandleRef pThis, int _arg);

		public virtual void SetRandomMode(int _arg)
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetRandomMode_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_SetScalarModeToCellData_13(HandleRef pThis);

		public void SetScalarModeToCellData()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetScalarModeToCellData_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcessIdScalars_SetScalarModeToPointData_14(HandleRef pThis);

		public void SetScalarModeToPointData()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetScalarModeToPointData_14(base.GetCppThis());
		}
	}
}
