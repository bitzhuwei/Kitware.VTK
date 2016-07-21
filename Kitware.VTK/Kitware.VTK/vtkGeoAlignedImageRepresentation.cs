using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoAlignedImageRepresentation : vtkDataRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoAlignedImageRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkGeoAlignedImageRepresentation()
		{
			vtkGeoAlignedImageRepresentation.MRClassNameKey = "class vtkGeoAlignedImageRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoAlignedImageRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoAlignedImageRepresentation"));
		}

		public vtkGeoAlignedImageRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAlignedImageRepresentation New()
		{
			vtkGeoAlignedImageRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAlignedImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoAlignedImageRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageRepresentation_GetBestImageForBounds_01(HandleRef pThis, IntPtr bounds, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoImageNode GetBestImageForBounds(IntPtr bounds)
		{
			vtkGeoImageNode vtkGeoImageNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_GetBestImageForBounds_01(base.GetCppThis(), bounds, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoImageNode = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoImageNode.Register(null);
				}
			}
			return vtkGeoImageNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageRepresentation_GetSource_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoSource GetSource()
		{
			vtkGeoSource vtkGeoSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_GetSource_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoSource = (vtkGeoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoSource.Register(null);
				}
			}
			return vtkGeoSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAlignedImageRepresentation_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAlignedImageRepresentation_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageRepresentation_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoAlignedImageRepresentation NewInstance()
		{
			vtkGeoAlignedImageRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAlignedImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageRepresentation_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAlignedImageRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkGeoAlignedImageRepresentation vtkGeoAlignedImageRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoAlignedImageRepresentation = (vtkGeoAlignedImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoAlignedImageRepresentation.Register(null);
				}
			}
			return vtkGeoAlignedImageRepresentation;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageRepresentation_SaveDatabase_08(HandleRef pThis, string path);

		public void SaveDatabase(string path)
		{
			vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_SaveDatabase_08(base.GetCppThis(), path);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageRepresentation_SetSource_09(HandleRef pThis, HandleRef source);

		public virtual void SetSource(vtkGeoSource source)
		{
			vtkGeoAlignedImageRepresentation.vtkGeoAlignedImageRepresentation_SetSource_09(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}
	}
}
