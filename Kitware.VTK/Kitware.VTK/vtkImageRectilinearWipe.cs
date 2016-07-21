using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageRectilinearWipe : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRectilinearWipe";

		public new static readonly string MRClassNameKey;

		static vtkImageRectilinearWipe()
		{
			vtkImageRectilinearWipe.MRClassNameKey = "class vtkImageRectilinearWipe";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRectilinearWipe.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRectilinearWipe"));
		}

		public vtkImageRectilinearWipe(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRectilinearWipe_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRectilinearWipe New()
		{
			vtkImageRectilinearWipe result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageRectilinearWipe() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageRectilinearWipe.vtkImageRectilinearWipe_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRectilinearWipe_GetAxis_01(HandleRef pThis);

		public virtual int[] GetAxis()
		{
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetAxis_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_GetAxis_02(HandleRef pThis, IntPtr data);

		public virtual void GetAxis(IntPtr data)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetAxis_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRectilinearWipe_GetPosition_03(HandleRef pThis);

		public virtual int[] GetPosition()
		{
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetPosition_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_GetPosition_04(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetPosition_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRectilinearWipe_GetWipe_05(HandleRef pThis);

		public virtual int GetWipe()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipe_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRectilinearWipe_GetWipeMaxValue_06(HandleRef pThis);

		public virtual int GetWipeMaxValue()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipeMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRectilinearWipe_GetWipeMinValue_07(HandleRef pThis);

		public virtual int GetWipeMinValue()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipeMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRectilinearWipe_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRectilinearWipe_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRectilinearWipe_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageRectilinearWipe NewInstance()
		{
			vtkImageRectilinearWipe result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRectilinearWipe_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRectilinearWipe SafeDownCast(vtkObjectBase o)
		{
			vtkImageRectilinearWipe vtkImageRectilinearWipe = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRectilinearWipe = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRectilinearWipe.Register(null);
				}
			}
			return vtkImageRectilinearWipe;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetAxis_13(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetAxis(int _arg1, int _arg2)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetAxis_13(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetAxis_14(HandleRef pThis, IntPtr _arg);

		public void SetAxis(IntPtr _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetAxis_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetInput1_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput1(vtkDataObject arg0)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetInput1_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetInput2_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput2(vtkDataObject arg0)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetInput2_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetPosition_17(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetPosition(int _arg1, int _arg2)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetPosition_17(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetPosition_18(HandleRef pThis, IntPtr _arg);

		public void SetPosition(IntPtr _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetPosition_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipe_19(HandleRef pThis, int _arg);

		public virtual void SetWipe(int _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipe_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToHorizontal_20(HandleRef pThis);

		public void SetWipeToHorizontal()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToHorizontal_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToLowerLeft_21(HandleRef pThis);

		public void SetWipeToLowerLeft()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToLowerLeft_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToLowerRight_22(HandleRef pThis);

		public void SetWipeToLowerRight()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToLowerRight_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToQuad_23(HandleRef pThis);

		public void SetWipeToQuad()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToQuad_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToUpperLeft_24(HandleRef pThis);

		public void SetWipeToUpperLeft()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToUpperLeft_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToUpperRight_25(HandleRef pThis);

		public void SetWipeToUpperRight()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToUpperRight_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRectilinearWipe_SetWipeToVertical_26(HandleRef pThis);

		public void SetWipeToVertical()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToVertical_26(base.GetCppThis());
		}
	}
}
