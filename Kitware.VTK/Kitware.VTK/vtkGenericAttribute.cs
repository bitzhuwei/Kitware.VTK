using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericAttribute : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttribute";

		public new static readonly string MRClassNameKey;

		static vtkGenericAttribute()
		{
			vtkGenericAttribute.MRClassNameKey = "class vtkGenericAttribute";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttribute"));
		}

		public vtkGenericAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_DeepCopy_01(HandleRef pThis, HandleRef other);

		public virtual void DeepCopy(vtkGenericAttribute other)
		{
			vtkGenericAttribute.vtkGenericAttribute_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericAttribute_GetActualMemorySize_02(HandleRef pThis);

		public virtual uint GetActualMemorySize()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetActualMemorySize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_GetCentering_03(HandleRef pThis);

		public virtual int GetCentering()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetCentering_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_GetComponent_04(HandleRef pThis, int i, HandleRef c, IntPtr values);

		public virtual void GetComponent(int i, vtkGenericCellIterator c, IntPtr values)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetComponent_04(base.GetCppThis(), i, (c == null) ? default(HandleRef) : c.GetCppThis(), values);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericAttribute_GetComponent_05(HandleRef pThis, int i, HandleRef p);

		public virtual double GetComponent(int i, vtkGenericPointIterator p)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetComponent_05(base.GetCppThis(), i, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_GetComponentType_06(HandleRef pThis);

		public virtual int GetComponentType()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetComponentType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericAttribute_GetMaxNorm_07(HandleRef pThis);

		public virtual double GetMaxNorm()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetMaxNorm_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_GetName_08(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkGenericAttribute.vtkGenericAttribute_GetName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_GetNumberOfComponents_09(HandleRef pThis);

		public virtual int GetNumberOfComponents()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetNumberOfComponents_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_GetRange_10(HandleRef pThis, int component);

		public virtual IntPtr GetRange(int component)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetRange_10(base.GetCppThis(), component);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_GetRange_11(HandleRef pThis, int component, IntPtr range);

		public virtual void GetRange(int component, IntPtr range)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetRange_11(base.GetCppThis(), component, range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericAttribute_GetSize_12(HandleRef pThis);

		public virtual long GetSize()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_13(HandleRef pThis, HandleRef c);

		public virtual IntPtr GetTuple(vtkGenericAdaptorCell c)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_13(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_GetTuple_14(HandleRef pThis, HandleRef c, IntPtr tuple);

		public virtual void GetTuple(vtkGenericAdaptorCell c, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_14(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_15(HandleRef pThis, HandleRef c);

		public virtual IntPtr GetTuple(vtkGenericCellIterator c)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_15(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_GetTuple_16(HandleRef pThis, HandleRef c, IntPtr tuple);

		public virtual void GetTuple(vtkGenericCellIterator c, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_16(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_GetTuple_17(HandleRef pThis, HandleRef p);

		public virtual IntPtr GetTuple(vtkGenericPointIterator p)
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetTuple_17(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAttribute_GetTuple_18(HandleRef pThis, HandleRef p, IntPtr tuple);

		public virtual void GetTuple(vtkGenericPointIterator p, IntPtr tuple)
		{
			vtkGenericAttribute.vtkGenericAttribute_GetTuple_18(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_GetType_19(HandleRef pThis);

		public virtual int GetTypeWrapper()
		{
			return vtkGenericAttribute.vtkGenericAttribute_GetType_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAttribute_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericAttribute.vtkGenericAttribute_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericAttribute NewInstance()
		{
			vtkGenericAttribute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttribute.vtkGenericAttribute_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAttribute_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAttribute vtkGenericAttribute = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAttribute.vtkGenericAttribute_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkGenericAttribute_ShallowCopy_24(HandleRef pThis, HandleRef other);

		public virtual void ShallowCopy(vtkGenericAttribute other)
		{
			vtkGenericAttribute.vtkGenericAttribute_ShallowCopy_24(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}
	}
}
