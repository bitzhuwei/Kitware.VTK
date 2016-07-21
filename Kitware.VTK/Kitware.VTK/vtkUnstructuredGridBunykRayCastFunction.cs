using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridBunykRayCastFunction : vtkUnstructuredGridVolumeRayCastFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridBunykRayCastFunction()
		{
			vtkUnstructuredGridBunykRayCastFunction.MRClassNameKey = "class vtkUnstructuredGridBunykRayCastFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridBunykRayCastFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction"));
		}

		public vtkUnstructuredGridBunykRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridBunykRayCastFunction New()
		{
			vtkUnstructuredGridBunykRayCastFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridBunykRayCastFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_Finalize_01(HandleRef pThis);

		public override void FinalizeWrapper()
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_Finalize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(HandleRef pThis);

		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(HandleRef pThis, IntPtr data);

		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(HandleRef pThis);

		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(HandleRef pThis, IntPtr data);

		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetPoints_06(HandleRef pThis);

		public IntPtr GetPoints()
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetPoints_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetViewToWorldMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_Initialize_08(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Initialize(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_Initialize_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridBunykRayCastFunction NewInstance()
		{
			vtkUnstructuredGridBunykRayCastFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewIterator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkUnstructuredGridVolumeRayCastIterator NewIterator()
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_NewIterator_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridBunykRayCastFunction SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridBunykRayCastFunction vtkUnstructuredGridBunykRayCastFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBunykRayCastFunction = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBunykRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridBunykRayCastFunction;
		}
	}
}
