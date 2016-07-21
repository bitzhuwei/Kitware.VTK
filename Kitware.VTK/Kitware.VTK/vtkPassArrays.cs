using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPassArrays : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassArrays";

		public new static readonly string MRClassNameKey;

		static vtkPassArrays()
		{
			vtkPassArrays.MRClassNameKey = "class vtkPassArrays";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassArrays.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassArrays"));
		}

		public vtkPassArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassArrays New()
		{
			vtkPassArrays result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPassArrays() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPassArrays.vtkPassArrays_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_AddArray_01(HandleRef pThis, int fieldType, string name);

		public virtual void AddArray(int fieldType, string name)
		{
			vtkPassArrays.vtkPassArrays_AddArray_01(base.GetCppThis(), fieldType, name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_AddFieldType_02(HandleRef pThis, int fieldType);

		public virtual void AddFieldType(int fieldType)
		{
			vtkPassArrays.vtkPassArrays_AddFieldType_02(base.GetCppThis(), fieldType);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_ClearArrays_03(HandleRef pThis);

		public virtual void ClearArrays()
		{
			vtkPassArrays.vtkPassArrays_ClearArrays_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_ClearFieldTypes_04(HandleRef pThis);

		public virtual void ClearFieldTypes()
		{
			vtkPassArrays.vtkPassArrays_ClearFieldTypes_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkPassArrays_GetRemoveArrays_05(HandleRef pThis);

		public virtual bool GetRemoveArrays()
		{
			return vtkPassArrays.vtkPassArrays_GetRemoveArrays_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkPassArrays_GetUseFieldTypes_06(HandleRef pThis);

		public virtual bool GetUseFieldTypes()
		{
			return vtkPassArrays.vtkPassArrays_GetUseFieldTypes_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassArrays_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPassArrays.vtkPassArrays_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassArrays_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPassArrays.vtkPassArrays_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassArrays_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPassArrays NewInstance()
		{
			vtkPassArrays result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_RemoveArraysOff_11(HandleRef pThis);

		public virtual void RemoveArraysOff()
		{
			vtkPassArrays.vtkPassArrays_RemoveArraysOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_RemoveArraysOn_12(HandleRef pThis);

		public virtual void RemoveArraysOn()
		{
			vtkPassArrays.vtkPassArrays_RemoveArraysOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassArrays_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassArrays SafeDownCast(vtkObjectBase o)
		{
			vtkPassArrays vtkPassArrays = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassArrays.vtkPassArrays_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassArrays = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassArrays.Register(null);
				}
			}
			return vtkPassArrays;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_SetRemoveArrays_14(HandleRef pThis, byte _arg);

		public virtual void SetRemoveArrays(bool _arg)
		{
			vtkPassArrays.vtkPassArrays_SetRemoveArrays_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_SetUseFieldTypes_15(HandleRef pThis, byte _arg);

		public virtual void SetUseFieldTypes(bool _arg)
		{
			vtkPassArrays.vtkPassArrays_SetUseFieldTypes_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_UseFieldTypesOff_16(HandleRef pThis);

		public virtual void UseFieldTypesOff()
		{
			vtkPassArrays.vtkPassArrays_UseFieldTypesOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassArrays_UseFieldTypesOn_17(HandleRef pThis);

		public virtual void UseFieldTypesOn()
		{
			vtkPassArrays.vtkPassArrays_UseFieldTypesOn_17(base.GetCppThis());
		}
	}
}
