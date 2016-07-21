using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAnnotationLayers : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLayers";

		public new static readonly string MRClassNameKey;

		static vtkAnnotationLayers()
		{
			vtkAnnotationLayers.MRClassNameKey = "class vtkAnnotationLayers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotationLayers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLayers"));
		}

		public vtkAnnotationLayers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLayers New()
		{
			vtkAnnotationLayers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAnnotationLayers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAnnotationLayers.vtkAnnotationLayers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_AddAnnotation_01(HandleRef pThis, HandleRef ann);

		public void AddAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_AddAnnotation_01(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_DeepCopy_02(HandleRef pThis, HandleRef other);

		public override void DeepCopy(vtkDataObject other)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_DeepCopy_02(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_GetAnnotation_03(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAnnotation GetAnnotation(uint idx)
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetAnnotation_03(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotation = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotation.Register(null);
				}
			}
			return vtkAnnotation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_GetCurrentAnnotation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAnnotation GetCurrentAnnotation()
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetCurrentAnnotation_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotation = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotation.Register(null);
				}
			}
			return vtkAnnotation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_GetCurrentSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection GetCurrentSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetCurrentSelection_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLayers GetData(vtkInformation info)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLayers GetData(vtkInformationVector v, int i)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkAnnotationLayers_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkAnnotationLayers_GetNumberOfAnnotations_09(HandleRef pThis);

		public uint GetNumberOfAnnotations()
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetNumberOfAnnotations_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_Initialize_10(HandleRef pThis);

		public override void Initialize()
		{
			vtkAnnotationLayers.vtkAnnotationLayers_Initialize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAnnotationLayers_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAnnotationLayers_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAnnotationLayers NewInstance()
		{
			vtkAnnotationLayers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_RemoveAnnotation_15(HandleRef pThis, HandleRef ann);

		public void RemoveAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_RemoveAnnotation_15(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLayers_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLayers SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_SetCurrentAnnotation_17(HandleRef pThis, HandleRef ann);

		public virtual void SetCurrentAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_SetCurrentAnnotation_17(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_SetCurrentSelection_18(HandleRef pThis, HandleRef sel);

		public virtual void SetCurrentSelection(vtkSelection sel)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_SetCurrentSelection_18(base.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAnnotationLayers_ShallowCopy_19(HandleRef pThis, HandleRef other);

		public override void ShallowCopy(vtkDataObject other)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_ShallowCopy_19(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}
	}
}
