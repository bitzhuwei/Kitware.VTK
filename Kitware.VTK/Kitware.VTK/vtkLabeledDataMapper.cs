using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabeledDataMapper : vtkMapper2D
	{
		public enum Coordinates
		{
			DISPLAY = 1,
			WORLD = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkLabeledDataMapper()
		{
			vtkLabeledDataMapper.MRClassNameKey = "class vtkLabeledDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledDataMapper"));
		}

		public vtkLabeledDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabeledDataMapper New()
		{
			vtkLabeledDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabeledDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabeledDataMapper.vtkLabeledDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_CoordinateSystemDisplay_01(HandleRef pThis);

		public void CoordinateSystemDisplay()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_CoordinateSystemDisplay_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_CoordinateSystemWorld_02(HandleRef pThis);

		public void CoordinateSystemWorld()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_CoordinateSystemWorld_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystem_03(HandleRef pThis);

		public virtual int GetCoordinateSystem()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystem_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMaxValue_04(HandleRef pThis);

		public virtual int GetCoordinateSystemMaxValue()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystemMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMinValue_05(HandleRef pThis);

		public virtual int GetCoordinateSystemMinValue()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystemMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetFieldDataArray_06(HandleRef pThis);

		public virtual int GetFieldDataArray()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetFieldDataArray_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetFieldDataName_07(HandleRef pThis);

		public virtual string GetFieldDataName()
		{
			return Marshal.PtrToStringAnsi(vtkLabeledDataMapper.vtkLabeledDataMapper_GetFieldDataName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetInput_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelFormat_09(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelFormat_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetLabelMode_10(HandleRef pThis);

		public virtual int GetLabelMode()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelTextProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_12(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty(int type)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelTextProperty_12(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_GetLabeledComponent_13(HandleRef pThis);

		public virtual int GetLabeledComponent()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabeledComponent_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkLabeledDataMapper_GetMTime_14(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetMTime_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_GetTransform_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetTransform_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledDataMapper_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabeledDataMapper NewInstance()
		{
			vtkLabeledDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_RenderOpaqueGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_RenderOverlay_22(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_RenderOverlay_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledDataMapper_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabeledDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledDataMapper vtkLabeledDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledDataMapper = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledDataMapper.Register(null);
				}
			}
			return vtkLabeledDataMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetCoordinateSystem_24(HandleRef pThis, int _arg);

		public virtual void SetCoordinateSystem(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetCoordinateSystem_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetFieldDataArray_25(HandleRef pThis, int arrayIndex);

		public void SetFieldDataArray(int arrayIndex)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetFieldDataArray_25(base.GetCppThis(), arrayIndex);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetFieldDataName_26(HandleRef pThis, string arrayName);

		public void SetFieldDataName(string arrayName)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetFieldDataName_26(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetInput_27(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetInput_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelFormat_28(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelFormat_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelMode_29(HandleRef pThis, int _arg);

		public virtual void SetLabelMode(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelMode_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelFieldData_30(HandleRef pThis);

		public void SetLabelModeToLabelFieldData()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelFieldData_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelIds_31(HandleRef pThis);

		public void SetLabelModeToLabelIds()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelIds_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelNormals_32(HandleRef pThis);

		public void SetLabelModeToLabelNormals()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelNormals_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelScalars_33(HandleRef pThis);

		public void SetLabelModeToLabelScalars()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelScalars_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTCoords_34(HandleRef pThis);

		public void SetLabelModeToLabelTCoords()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelTCoords_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTensors_35(HandleRef pThis);

		public void SetLabelModeToLabelTensors()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelTensors_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelVectors_36(HandleRef pThis);

		public void SetLabelModeToLabelVectors()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelVectors_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_37(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelTextProperty_37(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_38(HandleRef pThis, HandleRef p, int type);

		public virtual void SetLabelTextProperty(vtkTextProperty p, int type)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelTextProperty_38(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetLabeledComponent_39(HandleRef pThis, int _arg);

		public virtual void SetLabeledComponent(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabeledComponent_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledDataMapper_SetTransform_40(HandleRef pThis, HandleRef t);

		public void SetTransform(vtkTransform t)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetTransform_40(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}
	}
}
