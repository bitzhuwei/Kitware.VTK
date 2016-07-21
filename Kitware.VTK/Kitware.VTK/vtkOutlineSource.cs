using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutlineSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineSource";

		public new static readonly string MRClassNameKey;

		static vtkOutlineSource()
		{
			vtkOutlineSource.MRClassNameKey = "class vtkOutlineSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineSource"));
		}

		public vtkOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineSource New()
		{
			vtkOutlineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutlineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutlineSource.vtkOutlineSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_GenerateFacesOff_01(HandleRef pThis);

		public virtual void GenerateFacesOff()
		{
			vtkOutlineSource.vtkOutlineSource_GenerateFacesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_GenerateFacesOn_02(HandleRef pThis);

		public virtual void GenerateFacesOn()
		{
			vtkOutlineSource.vtkOutlineSource_GenerateFacesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineSource_GetBounds_03(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_GetBounds_04(HandleRef pThis, IntPtr data);

		public virtual void GetBounds(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_GetBounds_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineSource_GetBoxType_05(HandleRef pThis);

		public virtual int GetBoxType()
		{
			return vtkOutlineSource.vtkOutlineSource_GetBoxType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineSource_GetCorners_06(HandleRef pThis);

		public virtual double[] GetCorners()
		{
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_GetCorners_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_GetCorners_07(HandleRef pThis, IntPtr data);

		public virtual void GetCorners(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_GetCorners_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineSource_GetGenerateFaces_08(HandleRef pThis);

		public virtual int GetGenerateFaces()
		{
			return vtkOutlineSource.vtkOutlineSource_GetGenerateFaces_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineSource_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineSource_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutlineSource.vtkOutlineSource_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutlineSource NewInstance()
		{
			vtkOutlineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineSource SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineSource vtkOutlineSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineSource.vtkOutlineSource_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineSource = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineSource.Register(null);
				}
			}
			return vtkOutlineSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetBounds_14(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkOutlineSource.vtkOutlineSource_SetBounds_14(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetBounds_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetBounds_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetBoxType_16(HandleRef pThis, int _arg);

		public virtual void SetBoxType(int _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxType_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetBoxTypeToAxisAligned_17(HandleRef pThis);

		public void SetBoxTypeToAxisAligned()
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxTypeToAxisAligned_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetBoxTypeToOriented_18(HandleRef pThis);

		public void SetBoxTypeToOriented()
		{
			vtkOutlineSource.vtkOutlineSource_SetBoxTypeToOriented_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetCorners_19(HandleRef pThis, IntPtr data);

		public virtual void SetCorners(IntPtr data)
		{
			vtkOutlineSource.vtkOutlineSource_SetCorners_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineSource_SetGenerateFaces_20(HandleRef pThis, int _arg);

		public virtual void SetGenerateFaces(int _arg)
		{
			vtkOutlineSource.vtkOutlineSource_SetGenerateFaces_20(base.GetCppThis(), _arg);
		}
	}
}
