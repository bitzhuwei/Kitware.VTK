using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAnnotatedCubeActor : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotatedCubeActor";

		public new static readonly string MRClassNameKey;

		static vtkAnnotatedCubeActor()
		{
			vtkAnnotatedCubeActor.MRClassNameKey = "class vtkAnnotatedCubeActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotatedCubeActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotatedCubeActor"));
		}

		public vtkAnnotatedCubeActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotatedCubeActor New()
		{
			vtkAnnotatedCubeActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAnnotatedCubeActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_GetActors_01(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetActors_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetAssembly_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssembly GetAssembly()
		{
			vtkAssembly vtkAssembly = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetAssembly_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssembly = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssembly.Register(null);
				}
			}
			return vtkAssembly;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_GetBounds_03(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetBounds_03(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetBounds_04(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetCubeProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetCubeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetCubeProperty_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_GetCubeVisibility_06(HandleRef pThis);

		public int GetCubeVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetCubeVisibility_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAnnotatedCubeActor_GetFaceTextScale_07(HandleRef pThis);

		public virtual double GetFaceTextScale()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetFaceTextScale_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_GetFaceTextVisibility_08(HandleRef pThis);

		public int GetFaceTextVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetFaceTextVisibility_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkAnnotatedCubeActor_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetTextEdgesProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetTextEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetTextEdgesProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_GetTextEdgesVisibility_11(HandleRef pThis);

		public int GetTextEdgesVisibility()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetTextEdgesVisibility_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAnnotatedCubeActor_GetXFaceTextRotation_12(HandleRef pThis);

		public virtual double GetXFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXFaceTextRotation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXMinusFaceProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetXMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXMinusFaceProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXMinusFaceText_14(HandleRef pThis);

		public virtual string GetXMinusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXMinusFaceText_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXPlusFaceProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetXPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXPlusFaceProperty_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetXPlusFaceText_16(HandleRef pThis);

		public virtual string GetXPlusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetXPlusFaceText_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAnnotatedCubeActor_GetYFaceTextRotation_17(HandleRef pThis);

		public virtual double GetYFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYFaceTextRotation_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYMinusFaceProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetYMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYMinusFaceProperty_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYMinusFaceText_19(HandleRef pThis);

		public virtual string GetYMinusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYMinusFaceText_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYPlusFaceProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetYPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYPlusFaceProperty_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetYPlusFaceText_21(HandleRef pThis);

		public virtual string GetYPlusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetYPlusFaceText_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAnnotatedCubeActor_GetZFaceTextRotation_22(HandleRef pThis);

		public virtual double GetZFaceTextRotation()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZFaceTextRotation_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZMinusFaceProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetZMinusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZMinusFaceProperty_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZMinusFaceText_24(HandleRef pThis);

		public virtual string GetZMinusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZMinusFaceText_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZPlusFaceProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetZPlusFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZPlusFaceProperty_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_GetZPlusFaceText_26(HandleRef pThis);

		public virtual string GetZPlusFaceText()
		{
			return Marshal.PtrToStringAnsi(vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_GetZPlusFaceText_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_HasTranslucentPolygonalGeometry_27(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_HasTranslucentPolygonalGeometry_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAnnotatedCubeActor NewInstance()
		{
			vtkAnnotatedCubeActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_ReleaseGraphicsResources_32(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_ReleaseGraphicsResources_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_RenderOpaqueGeometry_33(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_RenderOpaqueGeometry_33(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAnnotatedCubeActor_RenderTranslucentPolygonalGeometry_34(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_RenderTranslucentPolygonalGeometry_34(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotatedCubeActor_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotatedCubeActor SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotatedCubeActor vtkAnnotatedCubeActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotatedCubeActor = (vtkAnnotatedCubeActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotatedCubeActor.Register(null);
				}
			}
			return vtkAnnotatedCubeActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetCubeVisibility_36(HandleRef pThis, int arg0);

		public void SetCubeVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetCubeVisibility_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetFaceTextScale_37(HandleRef pThis, double arg0);

		public void SetFaceTextScale(double arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetFaceTextScale_37(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetFaceTextVisibility_38(HandleRef pThis, int arg0);

		public void SetFaceTextVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetFaceTextVisibility_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetTextEdgesVisibility_39(HandleRef pThis, int arg0);

		public void SetTextEdgesVisibility(int arg0)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetTextEdgesVisibility_39(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetXFaceTextRotation_40(HandleRef pThis, double _arg);

		public virtual void SetXFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXFaceTextRotation_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetXMinusFaceText_41(HandleRef pThis, string _arg);

		public virtual void SetXMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXMinusFaceText_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetXPlusFaceText_42(HandleRef pThis, string _arg);

		public virtual void SetXPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetXPlusFaceText_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetYFaceTextRotation_43(HandleRef pThis, double _arg);

		public virtual void SetYFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYFaceTextRotation_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetYMinusFaceText_44(HandleRef pThis, string _arg);

		public virtual void SetYMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYMinusFaceText_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetYPlusFaceText_45(HandleRef pThis, string _arg);

		public virtual void SetYPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetYPlusFaceText_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetZFaceTextRotation_46(HandleRef pThis, double _arg);

		public virtual void SetZFaceTextRotation(double _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZFaceTextRotation_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetZMinusFaceText_47(HandleRef pThis, string _arg);

		public virtual void SetZMinusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZMinusFaceText_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_SetZPlusFaceText_48(HandleRef pThis, string _arg);

		public virtual void SetZPlusFaceText(string _arg)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_SetZPlusFaceText_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAnnotatedCubeActor_ShallowCopy_49(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAnnotatedCubeActor.vtkAnnotatedCubeActor_ShallowCopy_49(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
