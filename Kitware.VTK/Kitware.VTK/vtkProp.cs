using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProp : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp";

		public new static readonly string MRClassNameKey;

		static vtkProp()
		{
			vtkProp.MRClassNameKey = "class vtkProp";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp"));
		}

		public vtkProp(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_AddConsumer_01(HandleRef pThis, HandleRef c);

		public void AddConsumer(vtkObject c)
		{
			vtkProp.vtkProp_AddConsumer_01(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_AddEstimatedRenderTime_02(HandleRef pThis, double t, HandleRef arg1);

		public virtual void AddEstimatedRenderTime(double t, vtkViewport arg1)
		{
			vtkProp.vtkProp_AddEstimatedRenderTime_02(base.GetCppThis(), t, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_BuildPaths_03(HandleRef pThis, HandleRef paths, HandleRef path);

		public virtual void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkProp.vtkProp_BuildPaths_03(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_DragableOff_04(HandleRef pThis);

		public virtual void DragableOff()
		{
			vtkProp.vtkProp_DragableOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_DragableOn_05(HandleRef pThis);

		public virtual void DragableOn()
		{
			vtkProp.vtkProp_DragableOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_GetActors_06(HandleRef pThis, HandleRef arg0);

		public virtual void GetActors(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetActors_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_GetActors2D_07(HandleRef pThis, HandleRef arg0);

		public virtual void GetActors2D(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetActors2D_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkProp_GetAllocatedRenderTime_08(HandleRef pThis);

		public virtual double GetAllocatedRenderTime()
		{
			return vtkProp.vtkProp_GetAllocatedRenderTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_GetBounds_09(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkProp.vtkProp_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_GetConsumer_10(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject GetConsumer(int i)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_GetConsumer_10(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_GetDragable_11(HandleRef pThis);

		public virtual int GetDragable()
		{
			return vtkProp.vtkProp_GetDragable_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkProp_GetEstimatedRenderTime_12(HandleRef pThis, HandleRef arg0);

		public virtual double GetEstimatedRenderTime(vtkViewport arg0)
		{
			return vtkProp.vtkProp_GetEstimatedRenderTime_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkProp_GetEstimatedRenderTime_13(HandleRef pThis);

		public virtual double GetEstimatedRenderTime()
		{
			return vtkProp.vtkProp_GetEstimatedRenderTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_GetMatrix_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_GetMatrix_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_GetNextPath_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_GetNextPath_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_GetNumberOfConsumers_16(HandleRef pThis);

		public virtual int GetNumberOfConsumers()
		{
			return vtkProp.vtkProp_GetNumberOfConsumers_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_GetNumberOfPaths_17(HandleRef pThis);

		public virtual int GetNumberOfPaths()
		{
			return vtkProp.vtkProp_GetNumberOfPaths_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_GetPickable_18(HandleRef pThis);

		public virtual int GetPickable()
		{
			return vtkProp.vtkProp_GetPickable_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_GetPropertyKeys_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetPropertyKeys()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_GetPropertyKeys_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkProp_GetRedrawMTime_20(HandleRef pThis);

		public virtual uint GetRedrawMTime()
		{
			return vtkProp.vtkProp_GetRedrawMTime_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkProp_GetRenderTimeMultiplier_21(HandleRef pThis);

		public virtual double GetRenderTimeMultiplier()
		{
			return vtkProp.vtkProp_GetRenderTimeMultiplier_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_GetSupportsSelection_22(HandleRef pThis);

		public virtual bool GetSupportsSelection()
		{
			return vtkProp.vtkProp_GetSupportsSelection_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_GetUseBounds_23(HandleRef pThis);

		public virtual bool GetUseBounds()
		{
			return vtkProp.vtkProp_GetUseBounds_23(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_GetVisibility_24(HandleRef pThis);

		public virtual int GetVisibility()
		{
			return vtkProp.vtkProp_GetVisibility_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_GetVolumes_25(HandleRef pThis, HandleRef arg0);

		public virtual void GetVolumes(vtkPropCollection arg0)
		{
			vtkProp.vtkProp_GetVolumes_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_HasKeys_26(HandleRef pThis, HandleRef requiredKeys);

		public virtual bool HasKeys(vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_HasKeys_26(base.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_HasTranslucentPolygonalGeometry_27(HandleRef pThis);

		public virtual int HasTranslucentPolygonalGeometry()
		{
			return vtkProp.vtkProp_HasTranslucentPolygonalGeometry_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_InitPathTraversal_28(HandleRef pThis);

		public virtual void InitPathTraversal()
		{
			vtkProp.vtkProp_InitPathTraversal_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProp.vtkProp_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_IsConsumer_30(HandleRef pThis, HandleRef c);

		public int IsConsumer(vtkObject c)
		{
			return vtkProp.vtkProp_IsConsumer_30(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProp.vtkProp_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProp NewInstance()
		{
			vtkProp result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_Pick_33(HandleRef pThis);

		public virtual void Pick()
		{
			vtkProp.vtkProp_Pick_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_PickableOff_34(HandleRef pThis);

		public virtual void PickableOff()
		{
			vtkProp.vtkProp_PickableOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_PickableOn_35(HandleRef pThis);

		public virtual void PickableOn()
		{
			vtkProp.vtkProp_PickableOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_PokeMatrix_36(HandleRef pThis, HandleRef arg0);

		public virtual void PokeMatrix(vtkMatrix4x4 arg0)
		{
			vtkProp.vtkProp_PokeMatrix_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_ReleaseGraphicsResources_37(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProp.vtkProp_ReleaseGraphicsResources_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_RemoveConsumer_38(HandleRef pThis, HandleRef c);

		public void RemoveConsumer(vtkObject c)
		{
			vtkProp.vtkProp_RemoveConsumer_38(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_RenderFilteredOpaqueGeometry_39(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		public virtual bool RenderFilteredOpaqueGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredOpaqueGeometry_39(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_RenderFilteredOverlay_40(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		public virtual bool RenderFilteredOverlay(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredOverlay_40(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_RenderFilteredTranslucentPolygonalGeometry_41(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		public virtual bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredTranslucentPolygonalGeometry_41(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkProp_RenderFilteredVolumetricGeometry_42(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

		public virtual bool RenderFilteredVolumetricGeometry(vtkViewport v, vtkInformation requiredKeys)
		{
			return vtkProp.vtkProp_RenderFilteredVolumetricGeometry_42(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis(), (requiredKeys == null) ? default(HandleRef) : requiredKeys.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_RenderOpaqueGeometry_43(HandleRef pThis, HandleRef arg0);

		public virtual int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderOpaqueGeometry_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_RenderOverlay_44(HandleRef pThis, HandleRef arg0);

		public virtual int RenderOverlay(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderOverlay_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_RenderTranslucentPolygonalGeometry_45(HandleRef pThis, HandleRef arg0);

		public virtual int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderTranslucentPolygonalGeometry_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProp_RenderVolumetricGeometry_46(HandleRef pThis, HandleRef arg0);

		public virtual int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkProp.vtkProp_RenderVolumetricGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_RestoreEstimatedRenderTime_47(HandleRef pThis);

		public virtual void RestoreEstimatedRenderTime()
		{
			vtkProp.vtkProp_RestoreEstimatedRenderTime_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProp_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProp SafeDownCast(vtkObjectBase o)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp.vtkProp_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetAllocatedRenderTime_49(HandleRef pThis, double t, HandleRef arg1);

		public virtual void SetAllocatedRenderTime(double t, vtkViewport arg1)
		{
			vtkProp.vtkProp_SetAllocatedRenderTime_49(base.GetCppThis(), t, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetDragable_50(HandleRef pThis, int _arg);

		public virtual void SetDragable(int _arg)
		{
			vtkProp.vtkProp_SetDragable_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetEstimatedRenderTime_51(HandleRef pThis, double t);

		public virtual void SetEstimatedRenderTime(double t)
		{
			vtkProp.vtkProp_SetEstimatedRenderTime_51(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetPickable_52(HandleRef pThis, int _arg);

		public virtual void SetPickable(int _arg)
		{
			vtkProp.vtkProp_SetPickable_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetPropertyKeys_53(HandleRef pThis, HandleRef keys);

		public virtual void SetPropertyKeys(vtkInformation keys)
		{
			vtkProp.vtkProp_SetPropertyKeys_53(base.GetCppThis(), (keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetRenderTimeMultiplier_54(HandleRef pThis, double t);

		public void SetRenderTimeMultiplier(double t)
		{
			vtkProp.vtkProp_SetRenderTimeMultiplier_54(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetUseBounds_55(HandleRef pThis, byte _arg);

		public virtual void SetUseBounds(bool _arg)
		{
			vtkProp.vtkProp_SetUseBounds_55(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_SetVisibility_56(HandleRef pThis, int _arg);

		public virtual void SetVisibility(int _arg)
		{
			vtkProp.vtkProp_SetVisibility_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_ShallowCopy_57(HandleRef pThis, HandleRef prop);

		public virtual void ShallowCopy(vtkProp prop)
		{
			vtkProp.vtkProp_ShallowCopy_57(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_UseBoundsOff_58(HandleRef pThis);

		public virtual void UseBoundsOff()
		{
			vtkProp.vtkProp_UseBoundsOff_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_UseBoundsOn_59(HandleRef pThis);

		public virtual void UseBoundsOn()
		{
			vtkProp.vtkProp_UseBoundsOn_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_VisibilityOff_60(HandleRef pThis);

		public virtual void VisibilityOff()
		{
			vtkProp.vtkProp_VisibilityOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProp_VisibilityOn_61(HandleRef pThis);

		public virtual void VisibilityOn()
		{
			vtkProp.vtkProp_VisibilityOn_61(base.GetCppThis());
		}
	}
}
