using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericAttributeCollection : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttributeCollection";

		public new static readonly string MRClassNameKey;

		static vtkGenericAttributeCollection()
		{
			vtkGenericAttributeCollection.MRClassNameKey = "class vtkGenericAttributeCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAttributeCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttributeCollection"));
		}

		public vtkGenericAttributeCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttributeCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericAttributeCollection New()
		{
			vtkGenericAttributeCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericAttributeCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericAttributeCollection.vtkGenericAttributeCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_DeepCopy_01(HandleRef pThis, HandleRef other);

		public void DeepCopy(vtkGenericAttributeCollection other)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_FindAttribute_02(HandleRef pThis, string name);

		public int FindAttribute(string name)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_FindAttribute_02(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetActiveAttribute_03(HandleRef pThis);

		public virtual int GetActiveAttribute()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActiveAttribute_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetActiveComponent_04(HandleRef pThis);

		public virtual int GetActiveComponent()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActiveComponent_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericAttributeCollection_GetActualMemorySize_05(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetActualMemorySize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttributeCollection_GetAttribute_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGenericAttribute GetAttribute(int i)
		{
			vtkGenericAttribute vtkGenericAttribute = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttribute_06(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttribute = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttribute.Register(null);
				}
			}
			return vtkGenericAttribute;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetAttributeIndex_07(HandleRef pThis, int i);

		public int GetAttributeIndex(int i)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttributeIndex_07(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttributeCollection_GetAttributesToInterpolate_08(HandleRef pThis);

		public IntPtr GetAttributesToInterpolate()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetAttributesToInterpolate_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericAttributeCollection_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(HandleRef pThis);

		public int GetMaxNumberOfComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributes_11(HandleRef pThis);

		public int GetNumberOfAttributes()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfAttributes_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(HandleRef pThis);

		public virtual int GetNumberOfAttributesToInterpolate()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfComponents_13(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfComponents_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_14(HandleRef pThis);

		public int GetNumberOfPointCenteredComponents()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_HasAttribute_15(HandleRef pThis, int size, IntPtr attributes, int attribute);

		public int HasAttribute(int size, IntPtr attributes, int attribute)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_HasAttribute_15(base.GetCppThis(), size, attributes, attribute);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_InsertAttribute_16(HandleRef pThis, int i, HandleRef a);

		public void InsertAttribute(int i, vtkGenericAttribute a)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_InsertAttribute_16(base.GetCppThis(), i, (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_InsertNextAttribute_17(HandleRef pThis, HandleRef a);

		public void InsertNextAttribute(vtkGenericAttribute a)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_InsertNextAttribute_17(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_IsEmpty_19(HandleRef pThis);

		public int IsEmpty()
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsEmpty_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttributeCollection_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericAttributeCollection.vtkGenericAttributeCollection_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttributeCollection_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericAttributeCollection NewInstance()
		{
			vtkGenericAttributeCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_RemoveAttribute_23(HandleRef pThis, int i);

		public void RemoveAttribute(int i)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_RemoveAttribute_23(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_Reset_24(HandleRef pThis);

		public void Reset()
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_Reset_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttributeCollection_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericAttributeCollection SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAttributeCollection vtkGenericAttributeCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttributeCollection.vtkGenericAttributeCollection_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttributeCollection = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttributeCollection.Register(null);
				}
			}
			return vtkGenericAttributeCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_SetActiveAttribute_26(HandleRef pThis, int attribute, int component);

		public void SetActiveAttribute(int attribute, int component)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetActiveAttribute_26(base.GetCppThis(), attribute, component);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolate_27(HandleRef pThis, int size, IntPtr attributes);

		public void SetAttributesToInterpolate(int size, IntPtr attributes)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetAttributesToInterpolate_27(base.GetCppThis(), size, attributes);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_28(HandleRef pThis);

		public void SetAttributesToInterpolateToAll()
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttributeCollection_ShallowCopy_29(HandleRef pThis, HandleRef other);

		public void ShallowCopy(vtkGenericAttributeCollection other)
		{
			vtkGenericAttributeCollection.vtkGenericAttributeCollection_ShallowCopy_29(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}
	}
}
