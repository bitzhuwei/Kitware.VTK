using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredVisibilityConstraint : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredVisibilityConstraint";

		public new static readonly string MRClassNameKey;

		static vtkStructuredVisibilityConstraint()
		{
			vtkStructuredVisibilityConstraint.MRClassNameKey = "class vtkStructuredVisibilityConstraint";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredVisibilityConstraint.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredVisibilityConstraint"));
		}

		public vtkStructuredVisibilityConstraint(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredVisibilityConstraint_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredVisibilityConstraint New()
		{
			vtkStructuredVisibilityConstraint result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredVisibilityConstraint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredVisibilityConstraint() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_Blank_01(HandleRef pThis, long id);

		public void Blank(long id)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_Blank_01(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_DeepCopy_02(HandleRef pThis, HandleRef src);

		public void DeepCopy(vtkStructuredVisibilityConstraint src)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredVisibilityConstraint_GetDimensions_03(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_GetDimensions_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_GetDimensions_04(HandleRef pThis, IntPtr data);

		public virtual void GetDimensions(IntPtr data)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_GetDimensions_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredVisibilityConstraint_GetVisibilityById_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetVisibilityById()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_GetVisibilityById_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_Initialize_06(HandleRef pThis, IntPtr dims);

		public void Initialize(IntPtr dims)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_Initialize_06(base.GetCppThis(), dims);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredVisibilityConstraint_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkStructuredVisibilityConstraint_IsConstrained_08(HandleRef pThis);

		public byte IsConstrained()
		{
			return vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_IsConstrained_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredVisibilityConstraint_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkStructuredVisibilityConstraint_IsVisible_10(HandleRef pThis, long id);

		public byte IsVisible(long id)
		{
			return vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_IsVisible_10(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredVisibilityConstraint_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredVisibilityConstraint NewInstance()
		{
			vtkStructuredVisibilityConstraint result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredVisibilityConstraint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredVisibilityConstraint_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredVisibilityConstraint SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredVisibilityConstraint vtkStructuredVisibilityConstraint = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredVisibilityConstraint = (vtkStructuredVisibilityConstraint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredVisibilityConstraint.Register(null);
				}
			}
			return vtkStructuredVisibilityConstraint;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_SetVisibilityById_14(HandleRef pThis, HandleRef vis);

		public void SetVisibilityById(vtkUnsignedCharArray vis)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_SetVisibilityById_14(base.GetCppThis(), (vis == null) ? default(HandleRef) : vis.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_ShallowCopy_15(HandleRef pThis, HandleRef src);

		public void ShallowCopy(vtkStructuredVisibilityConstraint src)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_ShallowCopy_15(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredVisibilityConstraint_UnBlank_16(HandleRef pThis, long id);

		public void UnBlank(long id)
		{
			vtkStructuredVisibilityConstraint.vtkStructuredVisibilityConstraint_UnBlank_16(base.GetCppThis(), id);
		}
	}
}
