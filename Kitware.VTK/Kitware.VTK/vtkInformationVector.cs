using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationVector : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationVector";

		public new static readonly string MRClassNameKey;

		static vtkInformationVector()
		{
			vtkInformationVector.MRClassNameKey = "class vtkInformationVector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationVector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationVector"));
		}

		public vtkInformationVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationVector New()
		{
			vtkInformationVector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInformationVector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInformationVector.vtkInformationVector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_Register_09(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkInformationVector.vtkInformationVector_Register_09(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_UnRegister_14(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkInformationVector.vtkInformationVector_UnRegister_14(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_Append_01(HandleRef pThis, HandleRef info);

		public void Append(vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_Copy_02(HandleRef pThis, HandleRef from, int deep);

		public void Copy(vtkInformationVector from, int deep)
		{
			vtkInformationVector.vtkInformationVector_Copy_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationVector_GetInformationObject_03(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetInformationObject(int index)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_GetInformationObject_03(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationVector_GetNumberOfInformationObjects_04(HandleRef pThis);

		public int GetNumberOfInformationObjects()
		{
			return vtkInformationVector.vtkInformationVector_GetNumberOfInformationObjects_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationVector_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationVector.vtkInformationVector_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationVector_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationVector.vtkInformationVector_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationVector_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationVector NewInstance()
		{
			vtkInformationVector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_Remove_10(HandleRef pThis, HandleRef info);

		public void Remove(vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_Remove_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationVector_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationVector SafeDownCast(vtkObjectBase o)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_SetInformationObject_12(HandleRef pThis, int index, HandleRef info);

		public void SetInformationObject(int index, vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_SetInformationObject_12(base.GetCppThis(), index, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationVector_SetNumberOfInformationObjects_13(HandleRef pThis, int n);

		public void SetNumberOfInformationObjects(int n)
		{
			vtkInformationVector.vtkInformationVector_SetNumberOfInformationObjects_13(base.GetCppThis(), n);
		}
	}
}
